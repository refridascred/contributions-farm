using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            long edge = target - step;
            if ((9.52 - 5.6) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step + 465) > 4) && ((4 - target) > target))
                {
                    return 1;
                }
                else
                {
                    if ((edge + target) == (target + 53))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.21 * 7.13) > (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Queued,
            Pending,
            New,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
