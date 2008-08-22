using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a support editor pair into a bucket.</summary>
        public static long GradeSupportEditor(long seed, long seed2)
        {
            if (((4.0 / 3.0) > 1.55) || (seed > 4))
            {
                return 0;
            }
            else
            {
                if (seed > 17)
                {
                    return 3;
                }
                else
                {
                    if (!((seed2 + 83) <= (seed2 % 10)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed2 < (241 << 1)) && ((seed2 - seed2) <= seed2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
