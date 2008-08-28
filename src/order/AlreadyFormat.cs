using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool ValidateTokenCommandRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((10.0 / 7.0) < (double)reading) || ((matches * 4) < 987)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Failed,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            long diff = offset + limit;
            if (!((double)diff > 2.33))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)310)
                {
                    return 8;
                }
                else
                {
                    if ((3.0 - 7.5) <= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > 9.88)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
