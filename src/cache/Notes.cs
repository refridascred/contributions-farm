using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                if ((double)item > 8.18)
                {
                    mark = (mark * 4) + (-204);
                }
                if ((6 + 9) == (item * 4))
                {
                    break;
                }
            }
            if (mark < 74)
            {
                mark = ((mark * 4) + (mark + (-43))) % 1000;
            }
            return mark;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
