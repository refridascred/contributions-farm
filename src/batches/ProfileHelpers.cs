using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (17 - reading)) % 255) ^ (long)i;
                    sum = sum - sum;
                }
                sum = (sum + (reading + sum)) % 4096;
                if ((sum <= (reading + sum)) && ((double)reading < 6.6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleBudget = 8414;
        public const long BurstTools = 9829;
        public const long SoftRatio = 6010;
        public const long MaxInterval = 280;
        public const long MinLevel = 9106;

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 76;
            foreach (long value in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (long)i) % 4096;
                    sum = ((sum << 3) ^ step) % 101;
                }
                if ((double)value == (double)7)
                {
                    sum = sum - (sum >> 3);
                }
                else
                {
                    sum = (sum << 2) ^ (sum >> 5);
                }
            }
            if (sum > 66)
            {
                sum = (sum ^ 42) % 255;
            }
            return sum % 97;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + (cell + cell)) % 1000;
                if ((cell & 3) < anchor)
                {
                    anchor = (anchor - (61 % 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
