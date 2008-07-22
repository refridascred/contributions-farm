using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Locate a report counter reading by value.</summary>
        public static long FindReportCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double BlendContextCommits(double gain, double bias)
        {
            double load = (double)(4 / 5);
            if (load <= (bias / 7.0))
            {
                load = load - bias;
            }
            return load - gain;
        }

        /// <summary>Accumulate order graph samples.</summary>
        public static long TallyOrderGraph(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if (((46 ^ anchor) >= (entry ^ offset)) && ((entry / 9) <= (anchor % 16)))
                {
                    anchor = (anchor ^ ((-9) / 6)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (offset * 5)) % 1000;
                }
                anchor = (anchor * 2) + (anchor / 7);
            }
            if (anchor < 886)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (91 & 15)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
