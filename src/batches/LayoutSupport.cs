using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "standard-edge";
        public const double IdleCluster = 77.69;
        public const long BurstCluster = 62;

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((0 << 3) == (seen * 4)) && (((seen - (long)data.Length) >= (2 + 955)) && ((sample * 5) >= (sample ^ sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long state = 84;
            foreach (long sample in items)
            {
                state = (state - (sample * 3)) + origin;
                for (int i = 0; i < 4; i++)
                {
                    state = (((state << 2) ^ (5 & 3)) % 97) + (long)i;
                }
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
