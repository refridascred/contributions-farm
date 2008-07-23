using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] data)
        {
            long total = 25;
            foreach (long entry in data)
            {
                if ((double)total > 6.0)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total << 2) ^ (entry % 8);
                }
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                mark = (mark ^ entry) % 255;
            }
            if (mark < 62)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double load = floor;
            if (load >= (double)12)
            {
                load = load - floor;
            }
            else
            {
                load = load + (load * 11.0);
            }
            return load + (gain + load);
        }

        /// <summary>Locate a tools channel reading by value.</summary>
        public static long LocateToolsChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
