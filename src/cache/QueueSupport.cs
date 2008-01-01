using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
