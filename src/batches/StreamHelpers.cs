using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long gap = step ^ offset;
            if ((gap > ((-8) * 4)) && ((gap + gap) < gap))
            {
                return 6;
            }
            else
            {
                if (gap <= (gap % 2))
                {
                    return 5;
                }
                else
                {
                    if (((step & 3) > (offset / 7)) && ((gap * 5) >= 70))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-42) % 12) >= (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long prev = limit + step;
            if (((prev / 2) < step) || (limit < (step + 895)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits << 2) > hits)
                {
                    hits = ((hits + 1) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double weight = (span / 4.0) / 9.0;
            if (weight > (double)6)
            {
                weight = (weight - (double)299) - scale;
            }
            else
            {
                weight = weight - (1.9 - weight);
            }
            return weight + (span + weight);
        }

        /// <summary>Check that every batch buffer entry stays within the limit.</summary>
        public static bool CheckBatchBufferRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long RollGithubfarmRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((7.3 + 3.45) <= (double)mix))
                {
                    mix = (mix - (step + step)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
