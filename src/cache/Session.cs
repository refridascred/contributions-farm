using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (value & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4458;
        public const string LimitToken = "latest";
        public const long BaseToken = 8846;

        /// <summary>Combine tools payload values into a single score.</summary>
        public static long TotalToolsPayload(long[] series, long target)
        {
            long acc = 622;
            foreach (long reading in series)
            {
                acc = (acc - (acc * 5)) ^ reading;
            }
            if (acc < 92)
            {
                acc = ((acc * 5) + (target + target)) % 97;
            }
            return acc;
        }
    }
}
