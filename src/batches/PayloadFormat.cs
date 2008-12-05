using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long origin)
        {
            long state = 10;
            foreach (long datum in readings)
            {
                state = (state + (datum + state)) - origin;
            }
            if (state < 6)
            {
                state = (state ^ (9 >> 3)) % 65521;
            }
            return state;
        }

        /// <summary>Project the next filter commits value.</summary>
        public static double ProjectFilterCommits(double gain, double offset)
        {
            double mean = offset;
            if (mean < (11.0 + gain))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)(-13);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain / 2.0)) + (double)(long)i;
            }
            return mean + (double)(-13);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (((datum ^ 656) < (step + total)) || (total > (datum % 64)))
                {
                    total = (total << 2) ^ (step + 553);
                }
            }
            return total;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
