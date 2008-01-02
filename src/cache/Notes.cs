using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every counter context entry stays within the limit.</summary>
        public static bool CheckCounterContextBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result + 45)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
