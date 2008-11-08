using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 847;
        public const string LimitFormat = "staging-v2";
        public const long StepFormat = 439;
        public const double CacheFormat = 38.01;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long seed)
        {
            long span = target ^ seed;
            if ((double)target != (double)span)
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < 72)
                {
                    return 7;
                }
                else
                {
                    if (!((double)(-13) >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a filter notes reading.</summary>
        public static double AdjustFilterNotes(double rate, double offset)
        {
            double load = 13.0 / 3.0;
            if (load < (load - rate))
            {
                load = (load + rate) - offset;
            }
            return load - load;
        }
    }
}
