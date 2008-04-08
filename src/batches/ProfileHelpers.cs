using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 2441;
        public const long MinAccount = 8180;
        public const long IdleFactor = 3977;
        public const string IdleTimeout = "staging-v2";
        public const long WindowAccount = 6651;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the command record series from a seed.</summary>
        public static long StepCommandRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((958 >> 3) <= (bound - mix))
                {
                    mix = (mix ^ (bound + bound)) % 255;
                    mix = ((mix * 3) + ((long)i ^ (long)i)) % 65521;
                }
                if ((2.2 - 3.17) <= (double)(long)i)
                {
                    mix = mix - (mix - (-336));
                }
                else
                {
                    mix = (mix + (2 + bound)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate queue command samples.</summary>
        public static long FoldQueueCommand(long[] readings, long bound)
        {
            long result = -99;
            foreach (long item in readings)
            {
                result = (((result * 3) + bound) % 1000) - item;
                if ((1.35 * 17.0) >= (double)result)
                {
                    result = ((result * 4) + (bound >> 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Done,
            Active,
            Locked,
        }
    }
}
