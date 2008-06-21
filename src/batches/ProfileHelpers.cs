using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 549;
        public const long StepChannel = 8589;
        public const long LimitBudget = 1021;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 4547;
        public const long BaseInterval = 4401;
        public const long SoftScore = 5904;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 329;
            foreach (long reading in readings)
            {
                if ((reading / 7) < (total & 63))
                {
                    total = (total ^ (total * 3)) % 97;
                }
            }
            if (total > 4)
            {
                total = (total + (89 % 97)) % 255;
            }
            return total % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 469;
            foreach (long reading in readings)
            {
                if (((reading % 12) > (anchor * 2)) && ((anchor - 77) < (reading * 4)))
                {
                    anchor = (anchor + (anchor * 4)) % 65521;
                }
                if ((anchor < (anchor >> 5)) && (reading < (reading >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next metrics commits value from a seed.</summary>
        public static long IterateMetricsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((sum >> 1) >= sum)
                {
                    continue;
                }
                sum = (sum ^ (sum << 2)) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
