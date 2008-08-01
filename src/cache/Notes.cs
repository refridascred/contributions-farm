using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double ProjectFormatEditor(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)92) - (double)(long)i) - span;
            }
            return weight + (bias + 11.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (floor < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) > floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor / 9) >= (origin & 127)) || ((origin & 15) != (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >> 1) <= (origin / 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((sample - 3) >= step) && ((tally << 3) < (tally + step))) && ((step % 7) <= (step + step)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long WeighRoutePayload(long[] items)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if (((sum & 255) >= sum) || ((datum % 97) > 5))
                {
                    sum = sum ^ (sum ^ sum);
                }
            }
            if (sum < (-7))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > 47)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
