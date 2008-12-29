using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell - 480) >= count)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i < (6.28 * 6.09))
                {
                    result = (result - (result - 57)) % 1000;
                    result = result + 778;
                }
                if ((9.11 + 5.71) <= (double)(long)i)
                {
                    break;
                }
                result = ((result << 2) ^ (long)i) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (seen % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine queue route values into a single score.</summary>
        public static long WeighQueueRoute(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (value > (value % 12))
                {
                    carry = carry + (value & 7);
                }
            }
            if (carry < 984)
            {
                carry = carry - (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long TallyAccountProfileOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading >= (count % 100))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
