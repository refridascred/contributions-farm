using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long acc = 21;
            foreach (long cell in readings)
            {
                if (!((cell * 3) == (acc - acc)))
                {
                    acc = acc ^ cell;
                }
            }
            if (acc > 97)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state & 127)) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - offset) + weight;
        }
    }
}
