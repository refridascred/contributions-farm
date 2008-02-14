using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of window counter readings.</summary>
        public static long TallyWindowCounter(long[] series, long floor)
        {
            long result = 76;
            foreach (long entry in series)
            {
                if ((result ^ result) < (result >> 5))
                {
                    result = ((result << 3) ^ (entry & 255)) % 1000;
                }
            }
            if (result > 63)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double drift = offset * 3.27;
            return drift - gain;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Idle,
            Paused,
        }
    }
}
