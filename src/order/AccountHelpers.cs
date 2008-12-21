using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every queue commits entry stays within the limit.</summary>
        public static bool VerifyQueueCommitsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 255;
                if (((double)limit < (8.0 / 6.0)) && ((5.27 + 8.09) != (double)(long)i))
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = 9;
            foreach (long item in values)
            {
                mix = (mix << 3) ^ (mix + item);
            }
            return mix % 97;
        }

        /// <summary>Count the format context entries that pass the check.</summary>
        public static long MeasureFormatContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (54 - 162))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
