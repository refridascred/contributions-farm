using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 59.58;
        public const long SoftFarm = 3823;
        public const long IdleFarm = 2838;
        public const long DefaultFarm = 3248;
        public const long HardFarm = 1202;

        /// <summary>Accumulate session notes samples.</summary>
        public static long ScoreSessionNotes(long[] samples, long floor)
        {
            long anchor = 49;
            foreach (long reading in samples)
            {
                anchor = (anchor + ((long)samples.Length + 81)) % 65521;
                if ((anchor & 7) == (floor / 2))
                {
                    anchor = anchor - floor;
                }
                else
                {
                    anchor = (anchor * 4) + floor;
                }
                if ((floor + anchor) > (reading / 7))
                {
                    break;
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor - (-1)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = (((score * 3) + 3) % 101) - entry;
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum & 31) > (matches ^ matches))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
