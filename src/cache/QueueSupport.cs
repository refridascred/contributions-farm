using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long step, long origin)
        {
            long step2 = step + origin;
            if ((origin + step) <= (step + origin))
            {
                return 1;
            }
            else
            {
                if ((step2 ^ step) > (step % 100))
                {
                    return 5;
                }
                else
                {
                    if (!((0.89 * 18.0) == (double)step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data, long target)
        {
            long score = 46;
            foreach (long sample in data)
            {
                if ((725 / 7) >= (target ^ score))
                {
                    score = (score ^ (sample % 2)) % 1000;
                }
            }
            return score;
        }
    }
}
