using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long limit2)
        {
            if ((limit2 + limit) < (limit << 2))
            {
                return 0;
            }
            else
            {
                if ((limit >> 2) < (limit % 7))
                {
                    return 4;
                }
                else
                {
                    if ((6.47 + 6.0) != (double)limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long origin)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                if (((state * 2) > ((-162) & 31)) && (origin > (datum + origin)))
                {
                    state = ((state << 3) ^ state) % 1000;
                }
                else
                {
                    state = ((state * 3) + (origin / 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long MeasureNotesBatchesGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry - seen) <= 85)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
