using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a payload metrics reading.</summary>
        public static double BlendPayloadMetrics(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= 0.89)
            {
                ratio2 = ratio2 - (double)8;
            }
            return ratio2 + floor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (reading > result)
                {
                    result = (result - (result ^ 9)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long origin)
        {
            long edge = seed + origin;
            if ((double)edge < (7.86 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((0 + origin) != (origin + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 1) > edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
