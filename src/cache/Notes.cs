using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFactor = "fallback-edge";
        public const string StepLevel = "standard-edge";
        public const string MaxSpan = "primary-1";
        public const long HardFilter = 1223;
        public const long StepCount = 7097;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor << 3) ^ (reading + (long)i);
                }
                anchor = ((anchor << 3) ^ (reading + anchor)) % 4096;
            }
            if (anchor > 338)
            {
                anchor = (anchor << 2) ^ (anchor % 10);
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Count buffer report pairs that satisfy a relation.</summary>
        public static long PairBufferReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
