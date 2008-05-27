using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 499;
            foreach (long value in readings)
            {
                score = (score ^ (value - 5)) % 101;
            }
            if (score < 155)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long mark = 27;
            foreach (long datum in items)
            {
                if ((double)mark >= (3.2 + 7.63))
                {
                    mark = ((mark - (mark % 64)) % 97) + datum;
                    mark = mark ^ mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (978 + mark)) % 97;
                }
                mark = ((mark * 2) + mark) % 255;
            }
            if (mark < 54)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double bias = (double)(2 - 474);
            if (bias < 0.9)
            {
                bias = bias - (offset * 13.0);
            }
            return bias + rate;
        }
    }
}
