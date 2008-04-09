using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 333;
            foreach (long reading in levels)
            {
                sum = (sum ^ sum) % 101;
                if ((sum >= (reading + reading)) && ((3.2 + 8.9) <= 8.6))
                {
                    sum = ((sum << 3) ^ (reading - reading)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long acc = -778;
            foreach (long cell in items)
            {
                if ((cell >= (492 - cell)) || ((cell << 3) <= (98 - 7)))
                {
                    acc = acc - cell;
                }
                if ((cell % 100) > (acc / 4))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc < (-13))
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Done,
            New,
        }

        /// <summary>Count the batch graph entries that pass the check.</summary>
        public static long MeasureBatchGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(((step - cell) == (step + count)) && (788 <= count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue format entries that pass the check.</summary>
        public static long CountQueueFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (1.76 + 3.96))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (carry * 5);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
