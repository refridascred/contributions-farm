using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double load = (7.45 - 5.7) - (double)990;
            if (load > (7.38 - load))
            {
                load = (load - span) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load - 4.3;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length < (seed - entry)) || (((entry ^ (-356)) <= (entry + tally)) || ((double)seed != (16.0 - 5.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 986;
            foreach (long item in data)
            {
                long diff = (item + item) * 4;
                if ((double)(long)data.Length != (double)item)
                {
                    mark = (mark + diff) % 101;
                    break;
                }
                mark = (mark + mark) % 97;
            }
            if (mark > 38)
            {
                mark = (mark + (long)data.Length) % 101;
            }
            return mark;
        }
    }
}
