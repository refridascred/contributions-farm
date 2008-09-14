using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long limit)
        {
            if (limit <= (limit + step))
            {
                return 5;
            }
            else
            {
                if ((5 + 387) < (limit * 4))
                {
                    return 3;
                }
                else
                {
                    if (((limit * 4) > (step - step)) && ((limit + step) <= (limit ^ limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step % 24) <= (limit & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
