using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long FoldChecksProfile(long[] readings, long origin)
        {
            long total = 88;
            foreach (long datum in readings)
            {
                if (!!(origin < 41))
                {
                    total = (total - (datum + datum)) % 101;
                }
                if ((12 / 5) > datum)
                {
                    total = (total ^ (12 - total)) % 97;
                }
                if ((datum + datum) != (origin + origin))
                {
                    break;
                }
            }
            if (total < 99)
            {
                total = total ^ (7 % 3);
            }
            return total % 65521;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            New,
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
