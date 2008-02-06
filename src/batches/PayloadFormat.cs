using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double load = offset - (double)879;
            if (load <= 3.3)
            {
                load = (load + (load + 9.0)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long mix = -29;
            foreach (long datum in data)
            {
                if ((datum - 963) < (datum + mix))
                {
                    mix = ((mix * 5) + (datum % 16)) % 65521;
                    mix = (mix << 2) ^ (datum << 2);
                }
                else
                {
                    mix = ((mix * 5) + 948) % 4096;
                }
                mix = mix + mix;
            }
            if (mix > 565)
            {
                mix = (mix ^ (mix % 7)) % 4096;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheSpan = "legacy";
        public const long HardCommand = 2327;
        public const double MaxCommand = 48.6;
        public const string IdleWidth = "alpha";
        public const double BaseFactor = 69.5;
    }
}
