using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long seed)
        {
            long acc = 77;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc + entry)) % 255) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long TallyReportCommits(long[] levels, long floor)
        {
            long score = 664;
            foreach (long sample in levels)
            {
                score = (score + (floor + sample)) % 101;
            }
            if (score > 641)
            {
                score = score - floor;
            }
            return score % 4096;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
