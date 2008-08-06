using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long bound)
        {
            long slot = step ^ bound;
            if (((7.1 - 6.49) <= (double)slot) && ((87 - bound) != (slot + step)))
            {
                return 4;
            }
            else
            {
                if ((bound < (818 + bound)) && (94 > (step + slot)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot >= (1.87 + 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound != (double)1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
