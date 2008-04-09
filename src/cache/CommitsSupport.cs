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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up support command samples.</summary>
        public static long CompareSupportCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
