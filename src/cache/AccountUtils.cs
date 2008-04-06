using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            long slot = offset - step;
            if ((step / 7) < (step + step))
            {
                return 5;
            }
            else
            {
                if ((slot / 5) > (step / 2))
                {
                    return 7;
                }
                else
                {
                    if ((1.2 * 5.4) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((360 - offset) < (offset >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
