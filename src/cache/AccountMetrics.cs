using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long step)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if ((step - step) < (step ^ total))
                {
                    total = (total ^ ((-6) + cell)) % 255;
                }
                else
                {
                    total = (total * 4) + cell;
                }
            }
            if (total > 8)
            {
                total = ((total * 5) + (15 >> 1)) % 255;
            }
            return total % 97;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
