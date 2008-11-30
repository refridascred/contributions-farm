using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 2) ^ target) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long sum = -51;
            foreach (long sample in samples)
            {
                if ((13 << 1) == (sum * 3))
                {
                    sum = ((sum << 2) ^ (sample - sum)) % 97;
                }
                if (!((sum >> 4) < ((long)samples.Length - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum >= (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
