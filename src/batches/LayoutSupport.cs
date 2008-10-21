using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long floor)
        {
            long total = 8;
            foreach (long item in series)
            {
                total = ((((total * 3) + (370 % 10)) % 1000) - item) - floor;
            }
            return total % 1000;
        }

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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
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
