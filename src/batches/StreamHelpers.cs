using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = offset * 20.0;
            if (drift > ratio)
            {
                drift = drift - (ratio / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((sum << 3) > (sum - sum)))
                {
                    sum = (sum + (target % 7)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long score = 396;
            foreach (long cell in series)
            {
                if ((cell % 8) != (cell << 2))
                {
                    score = (score << 2) ^ (cell + score);
                }
            }
            return score;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches > 5.42) || ((sample << 2) < (matches - 282))) || ((sample % 60) < 57))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
