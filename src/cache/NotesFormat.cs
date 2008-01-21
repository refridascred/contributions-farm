using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a editor graph figure with a bias.</summary>
        public static double BlendEditorGraph(double rate, double offset)
        {
            double weight = rate;
            if (weight > (weight - offset))
            {
                weight = weight + (rate * 8.0);
            }
            else
            {
                weight = weight + (weight + 16.0);
            }
            return weight - weight;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (limit > (limit - bound))
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= 6.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (-46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
