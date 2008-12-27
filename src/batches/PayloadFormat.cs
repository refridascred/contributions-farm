using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next report format value from a seed.</summary>
        public static long DeriveReportFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((score + score) < score))
                {
                    score = (score << 2) ^ (origin << 1);
                    score = (score ^ (444 / 4)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch route sample.</summary>
        public static long SeekBatchRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
