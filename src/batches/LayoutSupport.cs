using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) > (origin * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches <= (matches ^ target)) && (reading < 886))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = (double)81 / 9.0;
            if (load <= 1.5)
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias * 7.48);
        }

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long ClassifyChannelNotes(long target, long limit)
        {
            long diff = target - limit;
            if (((limit + limit) > (limit * 2)) || ((diff << 3) >= 6))
            {
                return 1;
            }
            else
            {
                if (((-9) + target) >= (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (11.0 - 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
