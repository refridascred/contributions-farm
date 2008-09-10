using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Pending,
            Synced,
            New,
            Paused,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double load = (double)(84 + 9);
            if (load <= (double)463)
            {
                load = (load - bias) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - (double)3;
        }
    }
}
