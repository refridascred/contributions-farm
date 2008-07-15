using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry < (tally - tally)) || ((5.26 - 4.47) != (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            if (origin2 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 & 127) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (3 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 17.47;
        public const double IdleCommand = 34.36;
        public const long MinWidth = 4202;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
