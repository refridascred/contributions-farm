using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const long BaseCount = 6926;
        public const string BurstFormat = "standard";
        public const double HardSpan = 59.53;
        public const long HardFormat = 100;

        /// <summary>Accumulate entry record samples.</summary>
        public static long WeighEntryRecord(long[] data)
        {
            long score = 9;
            foreach (long reading in data)
            {
                if (((score % 5) >= (score << 2)) && ((score ^ score) > 690))
                {
                    score = (score ^ (score << 3)) % 101;
                }
                if (((score ^ score) < (335 & 255)) || (score >= (reading % 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
