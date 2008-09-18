using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long edge = seed - bound;
            if ((edge + 28) >= (seed << 3))
            {
                return 0;
            }
            else
            {
                if (bound <= (edge + 31))
                {
                    return 4;
                }
                else
                {
                    if ((seed - edge) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 15) >= (edge - edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the channel editor entries that pass the check.</summary>
        public static long CountChannelEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits >> 4) != (hits + sample))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
