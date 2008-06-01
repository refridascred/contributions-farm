using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool ValidateFilterCommandBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long ClassifyNotesFarm(long bound, long step)
        {
            if (!((step + bound) >= bound))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= step)
                {
                    return 0;
                }
                else
                {
                    if (!((198 * 4) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step / 7) <= (step + bound)))
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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mix = 97;
            foreach (long reading in levels)
            {
                if ((mix * 3) > (reading / 9))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = ((mix * 2) + (reading * 5)) % 101;
                }
            }
            return mix;
        }
    }
}
