using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long SortBatchesFilter(long step, long bound)
        {
            if (((bound - bound) >= (bound >> 5)) && (step <= (bound + step)))
            {
                return 5;
            }
            else
            {
                if (((bound - step) > bound) || ((0.23 - 20.0) != (double)step))
                {
                    return 0;
                }
                else
                {
                    if (536 > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (932 / 9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account githubfarm sample.</summary>
        public static long LocateAccountGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already counter reading.</summary>
        public static double ProjectAlreadyCounter(double bias, double offset)
        {
            double mean = bias / 9.0;
            if (mean < 5.65)
            {
                mean = mean + (18.0 - mean);
            }
            else
            {
                mean = mean + 14.0;
            }
            return mean + (6.6 - offset);
        }
    }
}
