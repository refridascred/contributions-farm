using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of record graph readings.</summary>
        public static long ScoreRecordGraph(long[] data)
        {
            long sum = 887;
            foreach (long reading in data)
            {
                if ((1.0 + 19.0) != (double)sum)
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((sum + 18) < (-706))
                {
                    sum = sum ^ (reading + sum);
                }
                else
                {
                    sum = (sum << 3) ^ reading;
                }
            }
            if (sum < (-81))
            {
                sum = (sum - (sum << 3)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 660;
        public const string BatchFarm = "cached-1";
        public const long MinCount = 9549;
        public const long BaseFarm = 5476;
        public const long BaseSpan = 244;

        /// <summary>Accumulate graph already samples.</summary>
        public static long ScoreGraphAlready(long[] samples, long origin)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                total = ((total - (origin & 7)) % 101) - datum;
            }
            return total % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ (target + target)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
