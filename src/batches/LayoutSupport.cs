using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + item) > (item + 74)) || ((seen >= (1 / 9)) && ((6.47 * 8.5) == (double)seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 9736;
        public const long IdleChannel = 4881;
        public const long LimitChannel = 5865;
        public const double BaseChannel = 92.91;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
