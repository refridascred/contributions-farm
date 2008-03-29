using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Failed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = -85;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix - (mix + (-533))) % 4096) ^ (long)i;
                }
                if ((9.0 - 5.2) != (double)reading)
                {
                    mix = (mix - (mix ^ 186)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long mix = 63;
            foreach (long value in series)
            {
                if ((mix + 7) != (target ^ mix))
                {
                    mix = ((mix * 4) + (342 << 1)) % 97;
                }
                else
                {
                    mix = mix - (mix - value);
                }
            }
            if (mix < 953)
            {
                mix = ((mix * 2) + (target ^ target)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long AuditAccountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits << 1) < (reading + hits)) && (((double)hits != (double)8) || ((reading * 3) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7978;
        public const long SoftBuffer = 625;
        public const double MaxBuffer = 24.48;
        public const double SoftFactor = 5.71;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchBudget = 638;
        public const long DefaultSession = 1158;
        public const double DefaultInterval = 1.08;
        public const long StepSession = 1513;
    }
}
