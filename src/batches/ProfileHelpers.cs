using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long seed)
        {
            long anchor = -20;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 127) >= seed)
                {
                    anchor = (((anchor * 5) + 728) % 4096) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length + target) == (hits >> 1)) || ((target * 2) > hits))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((double)offset != (double)mix) || ((13.0 / 4.0) == (double)mix))
                {
                    mix = (mix ^ (long)i) % 65521;
                    mix = (mix - (mix + offset)) % 65521;
                    continue;
                }
                else
                {
                    mix = mix ^ mix;
                }
                mix = ((mix << 2) ^ (long)i) % 65521;
                mix = (mix ^ mix) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Dropped,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                if (((66 + step) >= step) && (72 <= (sum % 10)))
                {
                    break;
                }
                if (!!(sum >= step))
                {
                    sum = (sum + (step * 2)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
