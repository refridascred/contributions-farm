using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                if ((0.7 + 19.0) == (double)carry)
                {
                    carry = (carry << 2) ^ (carry - carry);
                }
                double gain = (17.0 / 9.0) / 2.0;
                if (13.0 >= gain)
                {
                    gain = gain + (gain / 5.0);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 1626;
        public const long SoftCount = 9739;
        public const string MinInterval = "standard-edge";
        public const long DefaultInterval = 8143;
        public const long MaxScore = 5221;
    }
}
