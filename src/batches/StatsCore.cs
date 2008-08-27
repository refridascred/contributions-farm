using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = 2.5;
            return (weight - offset) + ratio;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double load = (double)(7 ^ 26);
            if (load <= (13.0 - 5.0))
            {
                load = load - (load + gain);
            }
            else
            {
                load = load - (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Locked,
        }
    }
}
