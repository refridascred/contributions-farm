using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((9 * 2) != (72 - hits)) && ((68 - hits) > 77)) || ((hits >> 5) == (37 ^ 58)))
                {
                    hits = ((hits + 3) ^ datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long AuditClusterCommitsMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)reading != (3.0 / 6.0)) && !(seen < (seen + 82)))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command record series from a seed.</summary>
        public static long StepCommandRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((958 >> 3) <= (bound - mix))
                {
                    mix = (mix ^ (bound + bound)) % 255;
                    mix = ((mix * 3) + ((long)i ^ (long)i)) % 65521;
                }
                if ((2.2 - 3.17) <= (double)(long)i)
                {
                    mix = mix - (mix - (-336));
                }
                else
                {
                    mix = (mix + (2 + bound)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long total = 48;
            foreach (long cell in values)
            {
                if ((total * 2) > (cell >> 3))
                {
                    total = total ^ cell;
                }
                else
                {
                    total = ((total << 2) ^ (total << 3)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate account farm samples.</summary>
        public static long CombineAccountFarm(long[] data, long origin)
        {
            long mix = 213;
            foreach (long datum in data)
            {
                mix = ((((mix * 2) + 61) % 1000) ^ datum) + origin;
            }
            return mix;
        }
    }
}
