using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Paused,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long target)
        {
            if (step < (target + target))
            {
                return 8;
            }
            else
            {
                if ((1 * 2) <= (target % 8))
                {
                    return 6;
                }
                else
                {
                    if ((target + 916) > (36 + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step / 8) > 4) && ((double)step != (18.0 - 20.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
