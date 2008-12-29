using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long acc = 612;
            foreach (long entry in levels)
            {
                if ((18.0 - 6.48) <= (double)entry)
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((floor % 10) == (entry / 8)) || (floor < (floor & 127)))
                {
                    break;
                }
            }
            if (acc < 350)
            {
                acc = (acc - floor) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long SeekAlreadyBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ matches) <= (568 & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks schema reading.</summary>
        public static double ScaleChecksSchema(double rate, double offset)
        {
            double drift = rate;
            if (drift <= drift)
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)72) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long step)
        {
            if ((3.0 - 8.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit < (limit >> 3)) || ((0 / 4) > (step / 4)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < (limit * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.4 / 5.0) >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
