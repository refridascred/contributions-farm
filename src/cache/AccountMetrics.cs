using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long limit, long target)
        {
            long lane = limit + target;
            if ((target + (-821)) > (limit * 4))
            {
                return 2;
            }
            else
            {
                if (3.5 >= (double)lane)
                {
                    return 3;
                }
                else
                {
                    if (((limit / 7) == (limit ^ lane)) || ((46 * 3) >= (lane << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane ^ 569) != (limit >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long step)
        {
            long total = 20;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ total) ^ datum) + step;
            }
            if (total < 2)
            {
                total = (total ^ ((-5) << 3)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                if (((entry >> 1) == (score - entry)) || (27 > (score % 100)))
                {
                    score = score - (entry << 1);
                }
            }
            if (score > 8)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Check that every context counter entry stays within the limit.</summary>
        public static bool ValidateContextCounterBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double gain2 = 2.0 + (gain * 3.8);
            if (gain2 <= (gain2 - gain))
            {
                gain2 = (gain2 - gain2) - span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (double)(-139);
        }
    }
}
