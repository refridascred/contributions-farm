using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Failed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order stats pair into a bucket.</summary>
        public static long BucketOrderStats(long floor, long floor2)
        {
            if ((floor2 + floor) < (1 / 7))
            {
                return 5;
            }
            else
            {
                if ((2.8 - 0.9) == (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > bias2)
            {
                scale = scale + 0.52;
            }
            else
            {
                scale = scale + (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 14.0)) - (double)(long)i;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
