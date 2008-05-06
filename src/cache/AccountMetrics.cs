using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Failed,
            Idle,
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

        /// <summary>Grade a batches record value against two limits.</summary>
        public static long BucketBatchesRecord(long step, long bound)
        {
            long offset = step + bound;
            if ((double)offset == (8.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((911 + 377) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((4.8 * 4.95) >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
