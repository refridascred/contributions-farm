using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long mix = 479;
            foreach (long value in readings)
            {
                mix = (((mix << 3) ^ (value >> 1)) % 1000) + floor;
            }
            if (mix < (-31))
            {
                mix = (mix + (mix << 1)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((7 + 39) >= seen)
                {
                    seen = ((seen + 1) + item) + target;
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double weight2 = 1.4;
            if (weight2 >= (double)1)
            {
                weight2 = weight2 + (weight2 - weight2);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (span / 9.0)) + (double)(long)i;
            }
            return weight2 + (5.0 - weight);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Dropped,
            Locked,
            Draft,
            Paused,
        }
    }
}
