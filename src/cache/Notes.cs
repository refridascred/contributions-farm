using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long TallyGithubfarmCounter(long[] samples)
        {
            long state = 717;
            foreach (long datum in samples)
            {
                state = (state + (datum + (-5))) % 97;
                if ((state >> 3) < state)
                {
                    break;
                }
            }
            return state % 97;
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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor < (floor ^ floor))
                {
                    score = (score * 3) + (floor >> 1);
                    score = ((score * 4) + (3 >> 3)) % 4096;
                }
                else
                {
                    score = (score - (score * 5)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score ^ (score ^ floor)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
