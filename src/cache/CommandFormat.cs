using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if ((327 + 83) > score)
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score * 2) + ((long)readings.Length - score)) % 65521;
                }
                if ((score + entry) <= (score * 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long step2)
        {
            long delta = step + step2;
            if ((step ^ step) < delta)
            {
                return 7;
            }
            else
            {
                if ((step - step2) >= step2)
                {
                    return 4;
                }
                else
                {
                    if (((delta << 3) == (step2 & 3)) && ((double)step < (9.0 / 9.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.5 * 1.0) < (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2609;
        public const double CacheReport = 34.84;
        public const double SoftFactor = 31.8;
    }
}
